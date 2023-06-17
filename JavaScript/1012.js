var input = process.argv[2];
var lines = input.split('/');

var A = Number(lines.shift());
var B = Number(lines.shift());
var C = Number(lines.shift());

var triangulo = (A*C)/2;
var circulo = 3.14159 * Math.pow(C, 2);
var trapezio = ((A + B) * C)/2;
var quadrado = Math.pow(B, 2);
var retangulo = A*B;

console.log(`TRIANGULO: ${triangulo.toFixed(3)}`);
console.log(`CIRCULO: ${circulo.toFixed(3)}`);
console.log(`TRAPEZIO: ${trapezio.toFixed(3)}`);
console.log(`QUADRADO: ${quadrado.toFixed(3)}`);
console.log(`RETANGULO: ${retangulo.toFixed(3)}`);