var canvas = document.getElementById('can');
var c = canvas.getContext('2d')

canvas.width = window.intterWidth;
canvas.height = window.innerHeight;

var canvas_stack = new CanvasStack('can');
var layer1 = canvas_stack.createLayer();
var layer1_ctx = document.getElementById(later1).getContext('2d');

// layer2
var layer2 = canvas_stack.createLayer();
var layer2_ctx = document.getElementById(later1).getContext('2d');

// we can use l1_ctx now

layer1_ctx.fillRect(0, 0, 100, 100);


// we can use l2_ctx now
// we can use l1_ctx now

layer1_ctx.fillStyle = 'red';
layer2_ctx.fillRect(0, 0, 100, 100);