var input = process.argv[2];
var lines = input.split('/');

var PROD = Number(lines[0]) * Number(lines[1]);

console.log(`PROD = ${PROD}`);