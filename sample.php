<?php


// Simulate a pizza ordering transaction
$pizzaMenu = [
    "Margherita" => 8.50,
    "Pepperoni" => 10.00,
    "Veggie" => 9.00,
    "BBQ Chicken" => 11.50
];

$customerOrder = "Pepperoni";
$quantity = 2;

if (array_key_exists($customerOrder, $pizzaMenu)) {
    $pricePerPizza = $pizzaMenu[$customerOrder];
    $totalCost = $pricePerPizza * $quantity;

    echo "You ordered $quantity $customerOrder pizza(s). \n";
    echo "Price per pizza: $$pricePerPizza \n";
    echo "Total cost: $$totalCost \n";
} else {
    echo "The selected pizza is not available.";
}
?>