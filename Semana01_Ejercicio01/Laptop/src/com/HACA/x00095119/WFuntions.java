package com.HACA.x00095119;

public class WFuntions {
    private int kilos=0;
    private  boolean TypeOfClothing, prueba;
    private double corriente=0;


    public WFuntions(int kilos, boolean TypeOfClothing) {
        this.kilos=kilos;
        this.setTypeOfClothing(TypeOfClothing);
    }


    public boolean FillWhirlpool() {
        if (getKilos()<=12) {
            System.out.println("Iniciando el espacio de llenado...");
            System.out.println("Confirmando llenado...");
            System.out.println("Llenado completo");
            return true;
        } else
            System.out.println("Has excedidido los kilos de ropa");
        return false;
    }
    public void WashingWhirlpool() {
        if(FillWhirlpool()){
            System.out.println("Iniciando proceso de lavado");
            if(getTypeOfClothing()){
                System.out.println("Inicia el lavado de ropa blanca...");
                System.out.println("Lavado de ropa blanca completado");
            } else {
                System.out.println("Inicia el lavado de ropa de color...");
                System.out.println("Lavado  de ropa de color completado");
            }
        }else
            System.out.println("Por favor reduce la carga de ropa!");
    }

    public int getKilos(){
        return kilos;
    }
    public void setKilos(int kilos){
        this.kilos=kilos;
    }
    public boolean getTypeOfClothing(){
        return TypeOfClothing;
    }
    public void setTypeOfClothing(boolean TypeOfClothing){
        this.TypeOfClothing= TypeOfClothing;
    }

    public void setPrueba(boolean prueba) {
        this.prueba = prueba;
    }
    public void setConsumo(Double Corriente){
        corriente=Corriente;
    }
    public Double getConsumo(){
        return corriente;
    }
}

