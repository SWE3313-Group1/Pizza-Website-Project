/* The code block you provided is establishing a connection to a MySQL database using PHP. Here's a
breakdown of what it does: */
<?php 
/* The code block you provided is setting up the connection parameters for connecting to a MySQL
database using PHP. Here's what each variable represents: */
$servername = "localhost";
$username = "root"; 
$password = "";
// if you have a password for your MySQL root user, replace the empty string with your password.
// if you have a different username, replace "root" with your username.
/* The line `$dbname = "pizza_shop";` is defining the name of the database you want to connect to.
$dbname = "pizza_shop";

/* The line ` = new mysqli(, , , );` is creating a new
instance of the `mysqli` class in PHP to establish a connection to a MySQL database. */

$conn = new mysqli($servername, $username, $password, $dbname);
/* The code block `if (->connect_error) { die("Connection failed: " . ->connect_error); }` is
a conditional statement that checks if there was an error while establishing the connection to the
MySQL database. */
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
/* The line ` = "SELECT * FROM pizza";` is assigning a SQL query to the variable ``. In this
case, the SQL query is selecting all columns (`*`) from the table named `pizza`. This query will
retrieve all rows and columns from the `pizza` table in the database connected to by the ``
object. */
   