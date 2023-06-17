var input = process.argv[2];
var lines = input.split('/');

var A = lines[0];
var B = lines[1];

var soma = Number(A) + Number(B);

console.log(`X = ${soma}`);