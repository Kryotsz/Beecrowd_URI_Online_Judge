var input = process.argv[2];
var lines = input.split('/');

var NUMBER = Number(lines[0]);

var SALARY = Number(lines[1]) * Number(lines[2]);

console.log(`NUMBER = ${NUMBER}`);
console.log(`SALARY = U$ ${SALARY.toFixed(2)}`);