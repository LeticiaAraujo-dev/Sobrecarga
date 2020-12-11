namespace Sobrecarga.classes
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }


        public string ComprarComDesconto(int parcelas){
            if(parcelas < 6){
                return "Você tem um desconto de 5% na compra";
            }else if(parcelas >= 6 && parcelas < 24){
                return "Você terá um juros de 10% do valor da compra";
            }else{
                return"Esse número de parcelas é invalido";
            }
        }
    }
}