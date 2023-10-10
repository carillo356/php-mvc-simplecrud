<?php

class DbConnection
{
    private $connection;
    protected function connect() {
        try{
            $username = "root";
            $password = "";
            $connection = new PDO('mysql:host=localhost;dbname=practicecrud', $username, $password);
            return $connection;
        }
        catch(PDOException $ex){
            die("Connection failed" . $ex->getMessage());
        }
    }

    protected function disconnect() {
        if($this->connection !== null) {
            $this->connection = null;
        }
    }
}