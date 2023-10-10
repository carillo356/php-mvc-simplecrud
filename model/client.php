<?php

class Client {
    private $id;
    private $name;
    private $email;
    private $date_created;

    public function setId($id){
        $this->id = $id;
    }

    public function getId(){
        return $this->id;
    }

    public function setName($name){
        $this->name = $name;
    }

    public function getName(){
        return $this->name;
    }

    public function setEmail($email){
        $this->email = $email;
    }

    public function getEmail(){
        return $this->email;
    }

    public function setDate_Created($date_created){
        $this->date_created = $date_created;
    }

    public function getDate_Created(){
        return $this->date_created;
    }
} 