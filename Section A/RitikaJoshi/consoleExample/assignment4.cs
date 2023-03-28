namespace MultipleInhertance {
    interface cal1 {
    float add(float a, float b);
    }

    interface cal2 {
        float sub(float a, float b);
    }

    interface cal3 {
        float mul(float a, float b);
    }

    interface cal4 {
        float div(float a, float b);
    }

    class Calculate: cal1, cal2, cal3, cal4 {
        public float add(float a, float b) {
            return a + b;
        }

        public float sub (float a, float b) {
            return a - b;
        }

        public float mul (float a, float b) {
            return a * b;
        }
        public float div (float a, float b) {
            return a / b;
        }
    }
}
