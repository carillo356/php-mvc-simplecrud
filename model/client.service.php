<?php

include "client.php";
include "practicecrud.repository.php";

class ClientService extends DbConnection {
    public function findAll() {
        $sql = "SELECT * FROM clients";
        $stmt = $this->connect()->prepare($sql);
        $stmt->execute();

        $results = $stmt->fetchAll(PDO::FETCH_ASSOC);

        $clients = array();

        foreach($results as $row) {
            $client = new Client();
            $client->setId($row['id']);
            $client->setName($row['name']);
            $client->setEmail($row['email']);
            $client->setDate_Created($row['date_created']);
            $clients[] = $client;
        }

        $this->disconnect();
        
        return $clients;
    }

    public function save($name, $email) {
        $sql = "INSERT INTO clients (name, email) VALUES (:name, :email)";
        $stmt = $this->connect()->prepare($sql);

        $stmt->bindParam(':name', $name);
        $stmt->bindParam(':email', $email);
        $stmt->execute();

        $this->disconnect();
    }

    public function delete($id) {
        $sql = "DELETE FROM clients WHERE id = :id";
        $stmt = $this->connect()->prepare($sql);

        $stmt->bindParam(':id', $id);
        $stmt->execute();

        $this->disconnect();
    }
    
    public function update($id, $name, $email) {
        $sql = "UPDATE clients SET name = :name, email = :email WHERE id = :id";
        $stmt = $this->connect()->prepare($sql);
    
        $stmt->bindParam(':id', $id);
        $stmt->bindParam(':name', $name);
        $stmt->bindParam(':email', $email);
        $stmt->execute();
        
        $this->disconnect();
    }

}