namespace clases{
    public class calculadora{
        public int Sumar(int a, int b){
            return a + b;
        }
        public int Restar(int a, int b){
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;  
        }
        public int Dividir(int a, int b) { 
            if (b == 0)
            throw new System.DivideByZeroException("No se puede dividir entre cero");
            else
                return a / b;  
        }
         
        
    }
}