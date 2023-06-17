var input = process.argv[2];
var lines = input.split('/');

var MEDIA = (Number(lines[0])*2 + Number(lines[1])*3 + Number(lines[2])*5)/10;

console.log(`MEDIA = ${MEDIA.toFixed(1)}`);