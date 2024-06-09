<?php
// Enable error reporting for debugging purposes
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

// Database connection
$con = mysqli_connect('localhost', 'root', 'root', 'unityaccess');

// Check if connection happened
if (mysqli_connect_errno()) {
    echo "1: Connection failed"; // error code #1 = connection failed
    exit();
}

// Check if POST variables are set
if (!isset($_POST['name']) || !isset($_POST['password'])) {
    echo "5: Missing POST variables"; // error code #5 - missing POST variables
    exit();
}

// Get user input and escape it
$username = mysqli_real_escape_string($con, $_POST['name']);
$password = mysqli_real_escape_string($con, $_POST['password']);

// Fetch hash and salt from the database
$query = "SELECT hash, salt FROM gameplayers WHERE username='" . $username . "';";
$result = mysqli_query($con, $query) or die("2: Query failed"); // error code #2 - query failed

if (mysqli_num_rows($result) != 1) {
    echo "3: Username not found"; // error code #3 - username not found
    exit();
}

$row = mysqli_fetch_assoc($result);
$hash = $row["hash"];
$salt = $row["salt"];

// Validate password
$loginhash = crypt($password, $salt); // Hash the password with the fetched salt

if ($hash != $loginhash) {
    echo "6: Incorrect username or password"; // error code #6 - incorrect username or password
    exit();
}

// Login successful
echo "0"; // success
?>
