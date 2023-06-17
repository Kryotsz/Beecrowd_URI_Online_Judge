var input = process.argv[2];
var lines = input.split('/');

var R = Number(lines[0]);

var volume = (4/3.0) * 3.14159 * Math.pow(R, 3);

console.log(`VOLUME = ${volume.toFixed(3)}`);