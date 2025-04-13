// --- cart.js (Cleaned, Text-Only Rendering) ---
$(document).ready(function() {

    console.log("Cart.js executing...");

    // --- Selectors ---
    const $orderBoxItems = $('#orderBoxItems');
    const $subtotalValue = $('#subtotalValue');
    const $estimatedTaxValue = $('#estimatedTaxValue');
    const $orderTotalValue = $('#orderTotalValue');
    const $emptyCartMessage = $('#emptyCartMessage');
    const taxRate = 0.07; // Example: 7% tax rate

    // --- Helper: Get Cart from Session Storage ---
    function getCart() {
        const cartString = sessionStorage.getItem('shoppingCart');
        try {
            const cart = cartString ? JSON.parse(cartString) : [];
            // Ensure it's actually an array
            return Array.isArray(cart) ? cart : [];
        } catch (e) {
            console.error("Error parsing shoppingCart from sessionStorage:", e);
            sessionStorage.removeItem('shoppingCart'); // Clear potentially corrupt data
            return [];
        }
    }

    // --- Helper: Save Cart to Session Storage (for removal) ---
    function saveCart(cart) {
        try {
            if (!Array.isArray(cart)) {
                console.error("Attempted to save non-array to cart:", cart);
                return;
            }
            sessionStorage.setItem('shoppingCart', JSON.stringify(cart));
            // Cart count update after removal should be handled by triggering
            // the function in customization.js if possible, or relying on next page load.
            // Avoid defining updateCartCount here.
            console.log("Cart saved after removal.");
            renderCart(); // Re-render the cart display after saving
        } catch (e) {
            console.error("Error saving cart to sessionStorage:", e);
        }
    }

    // --- Render Cart Items (Text Details Only) ---
    function renderCart() {
        console.log("Attempting to render cart...");
        const cart = getCart();
        console.log("Cart data retrieved:", JSON.stringify(cart)); // Log the raw data

        // Ensure target element exists
        if (!$orderBoxItems.length) {
            console.error("#orderBoxItems element not found in Cart.html!");
            return;
        }
        $orderBoxItems.empty(); // Clear previous items

        if (!cart || cart.length === 0) { // Check if cart is array and has items
            console.log("RenderCart: Cart is empty or invalid.");
            if ($emptyCartMessage.length) $emptyCartMessage.show();
            updateTotals(0); // Update totals to zero
            return;
        }

        if ($emptyCartMessage.length) $emptyCartMessage.hide();
        let currentSubtotal = 0;

        cart.forEach((item, index) => {
            console.log(`RenderCart: Processing item index ${index}, ID: ${item?.id}, Name: ${item?.name}`);

            // Validate item structure and price
            if (!item || typeof item !== 'object' || !item.id || !item.name) {
                console.warn(`Skipping invalid item at index ${index}:`, item);
                return; // Skip this item gracefully
            }
            const itemTotalPrice = Number(item.totalPrice);
            const itemPricePer = Number(item.pricePerItem);

            if (isNaN(itemTotalPrice) || isNaN(itemPricePer)) {
                console.warn(`Invalid price found for item ${item.name}. Price Total: ${item.totalPrice}, Price Per: ${item.pricePerItem}. Treating as 0.`);
            }
            currentSubtotal += (itemTotalPrice || 0); // Add valid price or 0

            // Build text details string safely
            let detailsHtml = `<p>Qty: ${Number(item.quantity) || 1}`; // Default qty 1
            if (item.size) detailsHtml += `, Size: ${item.size}`;
            if (item.crust) detailsHtml += `, Crust: ${item.crust}`;
            detailsHtml += `</p>`;

            if (item.toppings && Array.isArray(item.toppings) && item.toppings.length > 0) {
                detailsHtml += `<p>Toppings: ${item.toppings.join(', ')}</p>`;
            }
            if (item.subOptions && Array.isArray(item.subOptions) && item.subOptions.length > 0) {
                detailsHtml += `<p>Options: ${item.subOptions.join(', ')}</p>`;
            }
            if (item.instructions) {
                detailsHtml += `<p><i>Instructions: ${item.instructions}</i></p>`;
            }

            // Use basic item structure consistent with original CSS expectations
            const itemHtml = `
                <div class="cartItem" data-item-id="${item.id}">
                    <div style="float: right;">
                         <button class="removeCartItemBtn accountButtons" style="margin-left: 10px;">Remove</button>
                    </div>
                    <h4>${item.name}</h4>
                    ${detailsHtml}
                     <p style="font-weight: bold;">Price: $${(itemTotalPrice || 0).toFixed(2)}
                        ${item.quantity > 1 ? `<span style="font-weight: normal; font-size: 0.85em;"> ($${(itemPricePer || 0).toFixed(2)} each)</span>` : ''}
                    </p>
                    <div style="clear: both;"></div>
                </div>
            `;
            $orderBoxItems.append(itemHtml);
            console.log(`RenderCart: Appended HTML for: ${item.name}`);
        });

        console.log(`Cart rendered with ${cart.length} valid items. Subtotal: ${currentSubtotal}`);
        updateTotals(currentSubtotal);
    }

    // --- Update Totals Display ---
    function updateTotals(subtotal) {
        const tax = subtotal * taxRate;
        const total = subtotal + tax;

        // Check if elements exist before updating
        if ($subtotalValue.length) $subtotalValue.text(`$${subtotal.toFixed(2)}`); else console.warn("#subtotalValue not found.");
        if ($estimatedTaxValue.length) $estimatedTaxValue.text(`$${tax.toFixed(2)}`); else console.warn("#estimatedTaxValue not found.");
        if ($orderTotalValue.length) $orderTotalValue.text(`$${total.toFixed(2)}`); else console.warn("#orderTotalValue not found.");

        console.log(`Totals updated: Subtotal=$${subtotal.toFixed(2)}, Tax=$${tax.toFixed(2)}, Total=$${total.toFixed(2)}`);
    }

    // --- Remove Item Handler ---
    if ($orderBoxItems.length) {
        $orderBoxItems.on('click', '.removeCartItemBtn', function() {
            const $cartItemDiv = $(this).closest('.cartItem');
            const itemIdToRemove = parseFloat($cartItemDiv.data('item-id')); // Use parseFloat for ID with decimals

            if (isNaN(itemIdToRemove)) {
                console.error("Invalid item ID found for removal:", $cartItemDiv.data('item-id'));
                return;
            }

            let cart = getCart();
            console.log(`Attempting to remove item with ID: ${itemIdToRemove}`);
            const initialLength = cart.length;

            cart = cart.filter(item => parseFloat(item.id) !== itemIdToRemove); // Compare using parseFloat

            if (cart.length < initialLength) {
                console.log("Item found and filtered from cart array.");
                saveCart(cart); // Save the updated cart (this calls renderCart again)
            } else {
                console.warn("Could not find item in cart array with ID to remove:", itemIdToRemove);
            }
        });
    } else {
        console.warn("#orderBoxItems element not found, cannot attach remove listener.");
    }


    // --- Initial Load ---
    // Ensure essential elements exist before first render
    if ($orderBoxItems.length && $subtotalValue.length && $estimatedTaxValue.length && $orderTotalValue.length && $emptyCartMessage.length) {
        console.log("Essential cart elements found. Calling initial renderCart...");
        renderCart();
    } else {
        console.error("One or more essential cart display elements are missing from Cart.html! Cannot render cart.");
    }

}); // --- End of the SINGLE document ready block ---