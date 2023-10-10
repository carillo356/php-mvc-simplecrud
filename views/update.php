<?php
    include "../controller/client.controller.php";  
    $controller = new ClientController();

    if(isset($_POST['submit'])) {
        $id = $_POST['id'];
        $name = $_POST['name'];
        $email = $_POST['email'];
        
        if ($controller->update($id, $name, $email)) {
            header("Location: /php-mvc-simplecrud/views/index.php");
        } 
    }
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Practice Crud</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>

<body>
    <div class="container my-5">
        <h2>New Client</h2>
        <form method="post">
            <div class="row mb-3">
                <label class="col-sm-3 col-form-label">ClientID</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" name="id" value="">
                </div>
            </div>

            <div class="row mb-3">
                <label class="col-sm-3 col-form-label">Name</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" name="name" value="">
                </div>
            </div>

            <div class="row mb-3">
                <label class="col-sm-3 col-form-label">Email</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" name="email" value="">
                </div>
            </div>

            <div class="row mb-3">
                <div class="offset-sm-3 col-sm-3 d-grid">
                    <button type="submit" name="submit" class="btn btn-primary">Submit</button>
                </div>
                <div class="col-sm-3 d-grid">
                    <a class="btn btn-outline-primary" href="/php-mvc-simplecrud/views/index.php" role="button">Cancel</a>
                </div>
            </div>
        </form>
    </div>
</body>

</html>