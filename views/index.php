<?php
    include "../controller/client.controller.php";  
    $controller = new ClientController();
    $clients = $controller->readAll();  

    if(isset($_GET['id'])) {
        $id = $_GET['id'];
        $controller->delete($id);

        header("Location: /php-mvc-simplecrud/views/index.php");
        exit();
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Practice CRUD</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<body>
    <div class="container my-5">
        <h2>List of Clients</h2>
        <a class="btn btn-primary" href="/php-mvc-simplecrud/views/create.php" role="button">New Client</a>
        <br/><br/>

        <table class="table">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Date Created</th>
                    <th>Action</th>
                </tr>
            </thead>
            
            <tbody>
                <?php foreach ($clients as $client):?>
                    
                    <tr>
                        <td><?php echo $client->getId(); ?></td>
                        <td><?php echo $client->getName(); ?></td>
                        <td><?php echo $client->getEmail(); ?></td>
                        <td><?php echo $client->getDate_Created(); ?></td>
                        <td>
                            <a class="btn btn-primary btn-sm" href="/PracticeCrud/views/update.php">Edit</a>
                            <a class="btn btn-danger btn-sm" href="/practicecrud/views/index.php?id=<?php echo $client->getId()?>">Delete</a>
                        </td>
                    </tr>
                <?php endforeach; ?>
            </tbody>

        </table>
    </div>

    
</body>
</html>