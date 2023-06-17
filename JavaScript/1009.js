var input = process.argv[2];
var lines = input.split('/');

var nome = lines[0];
var salario = Number(lines[1]);
var montante = Number(lines[2]);

var total = salario + montante*0.15;

console.log(`TOTAL = R$ ${total.toFixed(2)}`);