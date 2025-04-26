-- Create database
CREATE database pizza_shop;
USE pizza_shop;

-- USERS table
CREATE TABLE users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    phone_number VARCHAR(15) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- ADDRESS TABLE
CREATE TABLE addresses (
    address_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT,
    street_address VARCHAR(100) NOT NULL,
    apt_suite VARCHAR(50),
    city VARCHAR(50) NOT NULL,
    state VARCHAR(2) NOT NULL,
    is_default BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (user_id)
        REFERENCES users (user_id)
);
    
    
    -- product categories table
CREATE TABLE product_category (
    category_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    description VARCHAR(255)
);
        
	-- products table
CREATE TABLE products (
    product_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description TEXT,
    base_price DECIMAL(10 , 2 ) NOT NULL,
    category_id INT NOT NULL,
    is_active BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (category_id)
        REFERENCES product_category (category_id)
);

-- pizza sizes table
	CREATE TABLE pizza_sizes (
    size_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(20) NOT NULL,
    price_adjustment DECIMAL(10 , 2 ) NOT NULL
);
    
-- pizza crusts table
CREATE TABLE pizza_crusts (
    crust_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(20) NOT NULL,
    price_adjustment DECIMAL(10 , 2 ) NOT NULL
);
        
-- toppings table
CREATE TABLE topping (
    topping_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    price DECIMAL(10 , 2 ) NOT NULL
);

-- subobtions table
CREATE TABLE sub_option (
    option_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    price DECIMAL(10 , 2 ) NOT NULL
);
    
    -- orders table
CREATE TABLE orders (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT,
    address_id INT,
    total_amount DECIMAL(10.2) NOT NULL,
    tax_amount DECIMAL(10 , 2 ) NOT NULL,
    order_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    order_status VARCHAR(20) DEFAULT 'PENDING',
    delivery_method VARCHAR(20) NOT NULL,
    special_instructions TEXT,
    FOREIGN KEY (user_id)
        REFERENCES users (user_id),
    FOREIGN KEY (address_id)
        REFERENCES addresses (address_id)
);

-- order items table
CREATE TABLE order_items (
    item_id INT AUTO_INCREMENT PRIMARY KEY,
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    unit_price DECIMAL(10 , 2 ) NOT NULL,
    total_price DECIMAL(10 , 2 ) NOT NULL,
    special_instructions TEXT,
    FOREIGN KEY (order_id)
        REFERENCES orders (order_id),
    FOREIGN KEY (product_id)
        REFERENCES products (product_id)
);

-- pizza order details table
CREATE TABLE pizz_order_details (
    detail_id INT AUTO_INCREMENT PRIMARY KEY,
    item_id INT NOT NULL,
    size_id INT,
    crust_id INT,
    FOREIGN KEY (item_id)
        REFERENCES order_items (item_id),
    FOREIGN KEY (size_id)
        REFERENCES pizza_sizes (size_id),
    FOREIGN KEY (crust_id)
        REFERENCES pizza_crusts (crust_id)
);

-- pizza toppings junction table 
CREATE TABLE order_item_toppins (
    id INT AUTO_INCREMENT PRIMARY KEY,
    item_id INT NOT NULL,
    topping_id INT NOT NULL,
    FOREIGN KEY (item_id)
        REFERENCES order_items (item_id),
    FOREIGN KEY (topping_id)
        REFERENCES topping (topping_id)
);

-- sub options junction table
CREATE TABLE order_items_sub_options (
    id INT AUTO_INCREMENT PRIMARY KEY,
    item_id INT NOT NULL,
    option_id INT NOT NULL,
    FOREIGN KEY (item_id)
        REFERENCES order_items (order_id),
    FOREIGN KEY (option_id)
        REFERENCES sub_option (option_id)
);

