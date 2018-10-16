<?php
require_once 'DBquery.php';
$_POST = json_decode(file_get_contents('php://input'), true);
$email= $_POST['email'];
$password = $_POST['password'];
$param = [
 "email"=>$email, 
 "password"=>password_hash($password, PASSWORD_DEFAULT)];
 print_r($param);
$db = new DBquery();
$newUserId = $db->insert('partner', $param);
print_r($newUserId);
// $d= new DateTime();
// $d->modify('+1 month');
// $password = $password.$email.'pakaded';
// $param = [
//     "UserId"=>$newUserId, 
//     "KeyLicense"=>password_hash($password, PASSWORD_DEFAULT),
//     "LifeTime"=>$d->format('Y-m-d')];
// $IdLicense = $db->insert('Licenses',$param);
// print_r($IdLicense);
//print_r($newUserId);
?>