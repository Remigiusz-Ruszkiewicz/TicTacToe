let isCircle = false
function GetCircle(id) {
    if (!isCircle) {
        var c = document.getElementById(id);
        var ctx = c.getContext("2d");
        ctx.beginPath();
        ctx.arc(70, 75, 70, 0, 2 * Math.PI);
        ctx.stroke();
        isCircle = true;
    }
    else {
        var c = document.getElementById(id);
        var ctx = c.getContext("2d");
        ctx.lineWidth = 1;
        ctx.beginPath();
        ctx.moveTo(0, 0);
        ctx.lineTo(c.width / 2, c.height);
        ctx.stroke();
        ctx.lineWidth = 1;
        ctx.beginPath();
        ctx.moveTo(c.width / 2, 0);
        ctx.lineTo(0, c.height);
        ctx.stroke();
        isCircle = false;
    }
}