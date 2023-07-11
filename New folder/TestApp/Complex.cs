namespace meth{
    public class Complex{
        public int Real {get; set;}

        public int Imaginary {get; set;}

        public Complex(){
            Real = 0;
            Imaginary = 0;
        }

        public Complex(int real, int imaginary){
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b){
            return new Complex(a.Real+b.Real,a.Imaginary+b.Imaginary);
        }

        public static Complex operator -(Complex a, Complex b){
            return new Complex(a.Real-b.Real,a.Imaginary-b.Imaginary);
        }

        public static Complex operator *(Complex a, Complex b){
            int real = ((a.Real*b.Real) + (a.Imaginary*b.Imaginary));
            int imaginary = ((a.Real*b.Imaginary) + (a.Imaginary*b.Real));
            return new Complex(real,imaginary);
        }


        public override string ToString() {
            return Real + " + "+Imaginary+"i";
        }
    }
}