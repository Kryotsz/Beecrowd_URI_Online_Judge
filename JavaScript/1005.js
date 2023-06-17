var input = process.argv[2];
var lines = input.split('/');

var MEDIA = (Number(lines[0])*3.5 + Number(lines[1])*7.5)/11;

console.log(`MEDIA = ${MEDIA.toFixed(5)}`);