package com.HACA.x00095119;

import java.util.Scanner;

public class Laptop {
    Scanner in = new Scanner(System.in);
    int option = 0;
    private String MyRam = "";
    private String MyModel = ""; //Atributos

    //Constructores
    public Laptop(String RAM, String Model) {
        this.setMyRam(RAM); //Utilizando setters
        this.setMyModel(Model);
    }
    public Laptop(){
        this.MyRam="seis gigas";
        this.MyModel="Lenovo";
    }
    public Laptop(String RAM){
        this.MyRam=RAM;
        this.MyModel="Lenovo";
    }
    public void Encender(){
    System.out.println("Se esta encendiendo...\nLaptop encendida correctamente");
    }
    public void Apagar(){
    System.out.println("Se esta apagando...\nHasta la proxima");
    }

    public void ComponentesLaptop () {
        System.out.println("Tu computadora tiene el modelo: " + MyModel + " Y posee una RAM de: " + MyRam);

        }

    public String getMyRam() {
        return MyRam;
    }

    public void setMyRam(String myRam) {
        MyRam = myRam;
    }

    public String getMyModel() {
        return MyModel;
    }

    public void setMyModel(String myModel) {
        MyModel = myModel;
    }
}