<?php

include "../model/client.service.php";

class ClientController {
    private $clientService;

    public function __construct() {
        $this->clientService = new ClientService();
    }

    public function create($name, $email) {
        $this->clientService->save($name, $email);
        return true;
    }

    public function readAll() {
        return $this->clientService->findAll();
    }

    public function update($id, $name, $email) {
        $this->clientService->update($id, $name, $email);
        return true;
    }

    public function delete($id) {
        $this->clientService->delete($id);
        return true;
    }


}