var i = 0;

function timedCount() {
     postMessage(++i);

    setTimeout("timedCount()", 100);
}

timedCount();