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

// Check if username exists
$namecheckquery = "SELECT username FROM gameplayers WHERE username='" . $username . "';";
$namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); // error code #2 - name check query failed

if (mysqli_num_rows($namecheck) > 0) {
    echo "3: Name already exists"; // error code #3 - name exists, cannot register
    exit();
}

// Add user to the table
$salt = "\$4\$rounds=4000\$" . "steamedhams" . $username . "\$";
$hash = crypt($password, $salt);
$insertuserquery = "INSERT INTO gameplayers (username, hash, salt) VALUES ('" . $username . "', '" . $hash . "', '" . $salt . "');";
mysqli_query($con, $insertuserquery) or die("4: Insert query failed"); // error code #4 - insert query failed

echo "0"; // Success

?>
