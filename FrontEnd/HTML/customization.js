// --- customization.js (SINGLE Corrected and Verified Version) ---
$(document).ready(function() {

    console.log("Customization script loaded and document ready.");

    // --- Selectors (Declared ONCE at the top) ---
    const $modalOverlay = $('#customizationModalOverlay');
    const $modal = $('#customizationModal');
    const $modalItemName = $('#modalItemName');
    const $itemQuantityInput = $('#itemQuantity');
    const $specialInstructionsInput = $('#specialInstructions');
    const $sizeOptions = $('#sizeOptions');
    const $crustOptions = $('#crustOptions');
    const $toppingOptions = $('#toppingOptions');
    const $subOptions = $('#subOptions');
    const $modalAddToCartBtn = $('#modalAddToCartBtn');
    const $modalCancelBtn = $('#modalCancelBtn');

    // --- Helper Functions (Defined ONCE) ---
    function getCart() {
        const cartString = sessionStorage.getItem('shoppingCart');
        try {
            // Ensure it returns an array even if parsing fails or storage is null
            return cartString ? JSON.parse(cartString) : [];
        } catch (e) {
            console.error("Error parsing shoppingCart from sessionStorage:", e);
            sessionStorage.removeItem('shoppingCart'); // Clear potentially corrupt data
            return [];
        }
    }

    function saveCart(cart) {
        try {
            // Ensure we are saving a valid array
            if (!Array.isArray(cart)) {
                console.error("Attempted to save non-array to cart:", cart);
                return; // Do not save invalid data
            }
            sessionStorage.setItem('shoppingCart', JSON.stringify(cart));
            updateCartCount(); // Update header count after saving
        } catch (e) {
            console.error("Error saving cart to sessionStorage:", e);
            // Consider potential storage quota errors
        }
    }

    function updateCartCount() {
        // This function updates the count IF the element exists.
        // It's okay if it doesn't find it sometimes (e.g., if called by saveCart before header loads).
        // The crucial initial update happens after the header loads.
        try {
            const cart = getCart();
            const totalItems = cart.reduce((sum, item) => sum + (Number(item.quantity) || 0), 0);
            const $cartCountElement = $('#cartItemCount'); // Selector for the count span

            if ($cartCountElement.length) { // Check if element exists *now*
                $cartCountElement.text(totalItems);
                // console.log(`Cart count updated to: ${totalItems}`); // Optional log for successful update
            } else {
                // Log that it wasn't found *at the time this specific call happened*
                console.log("Cart count element (#cartItemCount) not found when updateCartCount was called.");
            }
        } catch (e) {
            console.error("Error during updateCartCount execution:", e);
        }
    }

    function closeModal() {
        // Check if the selector returns a valid element before calling methods
        if ($modalOverlay && $modalOverlay.length) {
            $modalOverlay.hide();
            console.log("Modal closed.");
        } else {
            console.warn("Tried to close modal, but overlay element wasn't found.");
        }
    }

    function calculatePrice(type, size, crust, toppings, subOptions) {
        let basePrice = 0;
        const toppingCost = 2.00;
        const stuffedCrustCost = 3.00;
        const subOptionCost = 1.00;
        switch (type) {
            case 'pizza':
                basePrice = 14.99; // Base: Medium Regular
                switch (size) {
                    case 'Small': basePrice -= 3.00; break;
                    case 'Large': basePrice += 3.00; break;
                    case 'XL':    basePrice += 5.00; break;
                }
                if (crust === 'Stuffed') basePrice += stuffedCrustCost;
                if (Array.isArray(toppings)) basePrice += toppings.length * toppingCost;
                break;
            case 'sub':
                basePrice = 10.99;
                if (Array.isArray(subOptions)) basePrice += subOptions.length * subOptionCost;
                break;
            case 'dessert': basePrice = 6.99; break;
            case 'beverage': basePrice = 2.49; break;
            default: console.warn(`Unknown item type for price: ${type}`); basePrice = 5.00;
        }
        if (isNaN(basePrice)) { console.error("Price calc NaN for type:", type); return 0.00; }
        return parseFloat(basePrice.toFixed(2));
    }

    // --- Event Handlers (Attached ONCE) ---

    // --- Open Modal ---
    // --- customization.js ---
// ... (keep code outside the handler: selectors, helper functions, etc.) ...

// --- Open Modal --- UPDATED WITH LOGS ---
// Ensure #menuBody exists before attaching listener
    if ($('#menuBody').length) {
        $('#menuBody').on('click', '.addToOrderBtn', function(event) {
            console.log('[LOG] 1: Add to Order button clicked!'); // Log 1
            try {
                const $button = $(this);
                const itemName = $button.data('item-name');
                const itemType = $button.data('item-type');
                console.log(`[LOG] 2: Data retrieved - Name: ${itemName}, Type: ${itemType}`); // Log 2

                // --- Check 1: Data Attributes ---
                if (!itemName || !itemType) {
                    console.error("[STOP] Missing item name or type data attributes on the button!");
                    return; // Stop execution
                }
                console.log("[LOG] 3: Data attributes verified.");

                // --- Check 2: Essential Modal Elements ---
                if (!$modal.length) { console.error("[STOP] Modal container (#customizationModal) not found!"); return; }
                if (!$modalItemName.length) { console.error("[STOP] Modal title element (#modalItemName) not found!"); return; }
                console.log("[LOG] 4: Essential modal elements verified.");

                // --- Set Modal Content ---
                $modalItemName.text(`Customize: ${itemName}`);
                $modal.data({ itemName, itemType });
                console.log("[LOG] 5: Modal title and data set.");

                // --- Check 3: Option Elements ---
                if (!$itemQuantityInput.length || !$specialInstructionsInput.length || !$sizeOptions.length || !$crustOptions.length || !$toppingOptions.length || !$subOptions.length) {
                    console.warn("[WARN] One or more modal OPTION elements (quantity, size, etc.) not found! Proceeding cautiously.");
                    // Decide if this is critical - maybe it should stop? For now, just warn.
                    // return;
                } else {
                    console.log("[LOG] 6: Option elements verified.");
                }

                // --- Reset and Show/Hide Options ---
                console.log("[LOG] 7: Resetting/showing/hiding options...");
                if ($itemQuantityInput.length) $itemQuantityInput.val(1);
                if ($specialInstructionsInput.length) $specialInstructionsInput.val('');
                if ($sizeOptions.length) $sizeOptions.hide().find('input[name="itemSize"][value="Medium"]').prop('checked', true);
                if ($crustOptions.length) $crustOptions.hide().find('input[name="itemCrust"][value="Regular"]').prop('checked', true);
                if ($toppingOptions.length) $toppingOptions.hide().find('input[type="checkbox"]').prop('checked', false);
                if ($subOptions.length) $subOptions.hide().find('input[type="checkbox"]').prop('checked', false);
                console.log("[LOG] 8: Base options reset and hidden.");

                // --- Show based on type ---
                console.log(`[LOG] 9: Applying logic for item type: ${itemType}`);
                if (itemType === 'pizza') {
                    if ($sizeOptions.length) $sizeOptions.show();
                    // Append XL logic
                    if ($sizeOptions.length && $sizeOptions.find('#sizeXL').length === 0) {
                        $sizeOptions.append('<br><input type="radio" id="sizeXL" name="itemSize" value="XL"><label for="sizeXL">XL</label>');
                        console.log("[LOG] 9a: Appended XL size option.");
                    }
                    if ($crustOptions.length) $crustOptions.show();
                    if ($toppingOptions.length) $toppingOptions.show();
                    console.log("[LOG] 9b: Pizza options shown.");
                } else if (itemType === 'sub') {
                    if ($subOptions.length) $subOptions.show();
                    console.log("[LOG] 9c: Sub options shown.");
                } // Add other types if needed

                console.log("[LOG] 10: Option visibility logic complete.");

                // --- Check 4: Modal Overlay Element ---
                if (!$modalOverlay.length) {
                    console.error("[STOP] Modal overlay element (#customizationModalOverlay) not found!");
                    return; // Stop if overlay is missing
                }
                console.log("[LOG] 11: Modal overlay verified.");

                // --- Show Modal ---
                console.log("[LOG] 12: Attempting to show modal overlay...");
                $modalOverlay.css('display', 'flex'); // Make it visible
                console.log("[LOG] 13: Modal overlay display set to flex. Should be visible now.");

            } catch (error) {
                // Catch unexpected errors just in case
                console.error("Error inside addToOrderBtn click handler:", error);
            }
        });
    } else {
        console.error("#menuBody element not found, 'Add to Order' click listener NOT attached.");
    }

// ... (keep the rest of customization.js: closeModal, Add To Cart handler, calculatePrice, Initial Setup, etc.) ...


    // --- Close Modal Handlers ---
    if ($modalCancelBtn.length) $modalCancelBtn.on('click', closeModal);
    else console.warn("Modal Cancel button (#modalCancelBtn) not found.");

    if ($modalOverlay.length) $modalOverlay.on('click', function(event) { if (event.target === this) closeModal(); });
    else console.warn("Modal Overlay (#customizationModalOverlay) not found for click listener.");


    // --- Add Item to Cart (from Modal) ---
    if ($modalAddToCartBtn.length) {
        $modalAddToCartBtn.on('click', function() {
            console.log("Modal Add to Cart button clicked.");
            try {
                // Get data stored on modal
                const itemName = $modal.data('itemName');
                const itemType = $modal.data('itemType');

                // Basic validation for stored data
                if (!itemName || !itemType) {
                    console.error("Could not retrieve item name/type from modal data.");
                    alert("Error retrieving item details. Cannot add to cart.");
                    return;
                }

                const quantity = Math.max(1, parseInt($itemQuantityInput.val(), 10) || 1);
                $itemQuantityInput.val(quantity); // Correct input if needed
                const specialInstructions = $specialInstructionsInput.val()?.trim() ?? ""; // Use optional chaining and nullish coalescing

                // Retrieve options safely
                let selectedSize = $sizeOptions.is(':visible') ? $sizeOptions.find('input[name="itemSize"]:checked').val() : null;
                let selectedCrust = $crustOptions.is(':visible') ? $crustOptions.find('input[name="itemCrust"]:checked').val() : null;
                let selectedToppings = []; if ($toppingOptions.is(':visible')) { $toppingOptions.find('input[name="itemTopping"]:checked').each(function() { selectedToppings.push($(this).val()); }); }
                let selectedSubOptions = []; if ($subOptions.is(':visible')) { $subOptions.find('input[name="subOption"]:checked').each(function() { selectedSubOptions.push($(this).val()); }); }

                // Calculate price
                const pricePerItem = calculatePrice(itemType, selectedSize, selectedCrust, selectedToppings, selectedSubOptions);
                const totalPriceForItem = (pricePerItem * quantity);

                if (isNaN(totalPriceForItem)) { console.error("Calculated total price is NaN.", {pricePerItem, quantity}); alert("Error calculating price."); return; }

                // Create item (ensure imageUrl is handled if added later)
                const cartItem = {
                    id: Date.now() + Math.random(), name: itemName, type: itemType, quantity: quantity,
                    size: selectedSize, crust: selectedCrust, toppings: selectedToppings,
                    subOptions: selectedSubOptions, instructions: specialInstructions,
                    // imageUrl: $modal.data('imageUrl'), // Add this line back ONLY IF you implement image capture
                    pricePerItem: pricePerItem, totalPrice: parseFloat(totalPriceForItem.toFixed(2))
                };

                // Add to cart
                const cart = getCart();
                cart.push(cartItem);
                saveCart(cart); // saveCart calls updateCartCount

                console.log("Item added to cart:", cartItem);
                alert(`${quantity} x ${itemName} added to order! (Total: $${cartItem.totalPrice.toFixed(2)})`);
                closeModal();

            } catch(error) { console.error("Error in modal add to cart handler:", error); alert("Error adding item. See console."); }
        });
    } else { console.warn("Modal Add To Cart button (#modalAddToCartBtn) not found."); }


    // --- Initial Setup Calls ---

    // Load Header and Footer using Callbacks
    console.log("Setting up header/footer load callbacks...");
    if ($("header").length) {
        $("header").load("Header.html", function(response, status, xhr) { // Load header content
            if (status === "error") {
                console.error(`Error loading Header.html: ${xhr.status} ${xhr.statusText}`);
            } else if (status === "success") {
                console.log("Header.html loaded successfully. Calling initial updateCartCount.");
                updateCartCount(); // <<< IMPORTANT: Initial call happens ONLY AFTER success
            }
        });
    } else { console.warn("<header> element not found for loading content."); }

    if ($("footer").length) {
        $("footer").load("Footer.html", function(response, status, xhr){ // Load footer content
            if (status === "success") console.log("Footer loaded.");
            if (status === "error") console.error(`Error loading Footer.html: ${xhr.status} ${xhr.statusText}`);
        });
    } else { console.warn("<footer> element not found for loading content."); }

}); // --- End of the SINGLE document ready block ---