function verificarFibonacci() {
    let num = document.getElementById("num").value;
    let a = 0;
    let b = 1;
    
    while (b < num) {
      let temp = b;
      b = a + b;
      a = temp;
    }
    
    if (b == num) {
      document.getElementById("resultado").innerHTML = `${num} pertence à sequência de Fibonacci.`;
    } else {
      document.getElementById("resultado").innerHTML = `${num} não pertence à sequência de Fibonacci.`;
    }
  }