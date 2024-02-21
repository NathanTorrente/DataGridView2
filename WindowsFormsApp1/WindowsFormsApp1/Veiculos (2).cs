public class Veiculos
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public override string ToString() // Tostring servirá para retorna o valor do nome como string
    {
        return this.Nome;
    }
    public static Veiculos[] GetArray()
    {
        Veiculos[] veiculosArray = new Veiculos[4];

        veiculosArray[0] = new Veiculos();
        veiculosArray[0].Id = 1;
        veiculosArray[0].Nome = "Supra";

        veiculosArray[1] = new Veiculos();
        veiculosArray[1].Id = 2;
        veiculosArray[1].Nome = "Maverick";

        veiculosArray[2] = new Veiculos();
        veiculosArray[2].Id = 3;
        veiculosArray[2].Nome = "Cronos";

        veiculosArray[3] = new Veiculos();
        veiculosArray[3].Id = 4;
        veiculosArray[3].Nome = "Dodge Viper";

        return veiculosArray;

        
    }
}
