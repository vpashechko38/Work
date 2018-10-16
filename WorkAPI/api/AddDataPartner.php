<?php
    require_once 'DBquery.php';
    $_POST = empty($_POST) ? json_decode(file_get_contents('php://input'), true) : $_POST; //Если отпрявляют постом в форме, то читает переменную, иначе берет из инпута
    $actualBasis =  isset($_POST['actualBasis']) ?? "";
    $ActualAddress = isset($_POST['actualAddress']) ?? "";
    $bankName = isset($_POST['bankName']) ?? "";
    $bik = isset($_POST['bik']);
    $checkingAccount = isset($_POST['checkingAccount']) ?? "";
    $correspondentAccount = isset($_POST['correspondentAccount']) ?? "";
    $dateOfIssueCertificate = isset($_POST['dateOfIssueCertificate']) ?? "";
    $dateOfIssuePassport = isset($_POST['dateOfIssuePassport']) ?? "";
    $email = isset($_POST['email']) ?? "";
    $fio = isset($_POST['fio']) ?? "";
    $inn = isset($_POST['inn']) ?? "";
    $IssueByPassport = isset($_POST['IssueByPassport']) ?? "";
    $kpp = isset($_POST['kpp']) ?? "";
    $legalAddress = isset($_POST['legalAddress']) ?? "";
    $nameOrganization = isset($_POST['nameOrganization']) ?? "";
    $ogrn = isset($_POST['ogrn']) ?? "";
    $ogrnip = isset($_POST['ogrnip']) ?? "";
    $password = isset($_POST['password']) ?? "";
    $phoneNumber = isset($_POST['phoneNumber']) ?? "";
    $position = isset($_POSt['position']) ?? "";
    $seriesAndNumberCertificate = isset($_POSt['seriesAndNumberCertificate']) ?? "";
    $seriesAndNumberPassport = isset($_POSt['seriesAndNumberPassport']) ?? "";
    $success = isset($_POST['success']) ?? "";
    $typeClient = isset($_POST['typeCliet']);
    $unitCodePassport = isset($_POST['unitCodePassport']);
    $sql = "UPDATE `partner` SET actualBasis = :actualBases, actualAddress = :actualAddress, bankName = :bankName, bik = :bik, checkingAccount = :checkingAccount, correspondentAccount = :correspondentAccount, dateOfIssueCertificate = :dateOfIssueCertificate,
    dateOfIssuePassport = :dateOfIssuePassport, fio = :fio, inn=:inn, IssueByPassport = :IssueByPassport, kpp=:kpp, legalAddress= :legalAddress,  
    nameOrganization = :nameOrganization, ogrn = :ogrn, ogrnip = :ogrnip,phoneNumber = :phoneNumber, position=:position,  seriesAndNumberCertificate=:seriesAndNumberCertificate,
    seriesAndNumberPassport=:seriesAndNumberPassport, unitCodePassport=:unitCodePassport";
    $param = [""]
?>