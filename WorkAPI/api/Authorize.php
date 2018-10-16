<?php
require_once 'DBquery.php';
$_POST = empty($_POST) ? json_decode(file_get_contents('php://input'), true) : $_POST; //Если отпрявляют постом в форме, то читает переменную, иначе берет из инпута
$email =  $_POST['email'];
$password = $_POST['password'];
$sql = "SELECT `email`, `password`, `inn` FROM `partner` WHERE email = :email";
$param = [ ":email" => $email ];
//print_r($email);
$db = new DBquery();
$query = $db->queryRow($sql, $param);
//print_r($query);
$checkPas;
if(password_verify($password, $query['password'])){
$checkPas = 'true';
}
else{
    $checkPas = 'false';
}
//$checkPas = password_verify($password, $query['password'])?'true':'false';
//$INN = $query['INN']==null?"goaddinfoorgan":"goaddorders";
print_r($checkPas);
?>