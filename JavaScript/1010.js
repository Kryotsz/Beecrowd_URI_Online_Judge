var input = process.argv[2];
var lines = input.split('/');

var array1 = lines.shift().split(' ');
var array2 = lines.shift().split(' ');

var cod1 = array1[0];
var qtde1 = Number(array1[1]);
var valor1 = Number(array1[2]);

var cod2 = array2[0];
var qtde2 = Number(array2[1]);
var valor2 = Number(array2[2]);

var total = qtde1 * valor1 + qtde2 * valor2;

console.log(`VALOR A PAGAR: R$ ${total.toFixed(2)}`);