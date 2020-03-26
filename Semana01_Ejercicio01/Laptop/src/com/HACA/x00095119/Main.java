/*
 * Primera clase: Clase laptop, funciones basicas de una laptop mas mostrando sus componentes
 * Segunda clase: Lavadora, realiza funciones de llenado y lavado
 * Creado por: Henry Alexander Cortez Amaya
 * Version: 1.0
 * No hay mods
 */
package com.HACA.x00095119;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner in= new Scanner(System.in);
        //Class Laptop
        String RAM="", Model="";
        System.out.println("Ingresa el modelo que deseas: ");
        System.out.println("1. Mac ");
        System.out.println("2. Window ");
        byte option=in.nextByte(); in.nextLine();
        switch (option) {
            case 1:
                Model="Mac";
                break;
            case 2:
                Model="Window";
                break;
            default:
                System.out.println("Se te asignara Mac por loco");
                Model="Mac";
                break;
        }
        System.out.println("Ingresa la RAM que deseas: ");
        System.out.println("1. cuatro gigas ");
        System.out.println("2. doce gigas ");
        option=in.nextByte(); in.nextLine();
        switch (option) {
            case 1:
                RAM="Cuatro gigas";
                break;
            case 2:
                RAM="Doce gigas";
                break;
            default:
                System.out.println("Se te asignara dos gigas de RAM por loco");
                RAM="Dos gigas";
                break;
        }
        Laptop MyLaptop= new Laptop(RAM,Model);
        System.out.println("----Laptop Numero 1----");
        MyLaptop.Encender();
        MyLaptop.Apagar();
        MyLaptop.ComponentesLaptop();
        Laptop MyLaptop01= new Laptop("","");
        System.out.println("----Laptop Numero 2----");
        MyLaptop01.Encender();
        MyLaptop01.Apagar();
        MyLaptop01.setMyModel("MacOS");
        MyLaptop01.setMyRam("Nueve gigas");
        System.out.println("Tu computadora tiene el modelo: " + MyLaptop01.getMyModel() + " Y posee una RAM de: " + MyLaptop01.getMyRam());
        System.out.println("----Laptop Numero 3----");
        Laptop MyLaptop02 = new Laptop("Nuevo gigas");
        MyLaptop02.Encender();
        MyLaptop02.Apagar();
        MyLaptop02.setMyModel("MacOS");
        MyLaptop02.setMyRam("Nueve gigas");
        MyLaptop02.ComponentesLaptop();
        //Class Whirlpool
        boolean TypeOfClothing=true;
        System.out.print("Ingresa los kilos que deseas lavar(Maximo 12 kilos): ");
        int kilos= in.nextInt(); in.nextLine();
        System.out.println("El tipo de lavada sera suave para ropa blanca y fuerte para ropa de color");
        System.out.print("Ingresa el tipo de ropa (1-blanca/2-Color) : ");
        int typeOC= in.nextInt(); in.nextLine();
        if(typeOC==1)
            TypeOfClothing = true;
        else
            TypeOfClothing= false;

        WFuntions WhirlpoolFuntions = new WFuntions(kilos,TypeOfClothing);
        WhirlpoolFuntions.WashingWhirlpool();
    }
}
