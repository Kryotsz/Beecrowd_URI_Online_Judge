var input = process.argv[2];
var lines = input.split('/');

var a = lines[0];
var b = lines[1];

var soma = Number(a) + Number(b);

console.log(`SOMA = ${soma}`);