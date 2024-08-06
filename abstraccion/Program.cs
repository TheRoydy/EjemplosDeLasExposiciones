using System;

var Carro = new CarroElectrico();
void CargarYAndar(Carro carro)
{
    carro.cargarEnergia();
    carro.andar();
}
abstract class Transporte
{
    public abstract void cargarEnergia();
    public abstract void aborda();

}

abstract class Carro : Transporte
{
    public abstract void andar();
    public abstract void parar();
}

class CarroElectrico : Carro
{
    public override void cargarEnergia() { }
    public override void aborda() { }
    public override void andar() { } 
    public override void parar() { }
}

class CarroAGasolina : Carro
{
    public override void cargarEnergia() { }
    public override void aborda() { }
    public override void andar() { }
    public override void parar() { }
}
