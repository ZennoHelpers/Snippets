let xPathTarget = document.evaluate(`id('content')`, document.documentElement, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null);
let node = xPathTarget.singleNodeValue;

// Что необходимо учитывать:

// выполнением таймера управляет браузер (может влиять режим энергосбережения!)
// так как таймер создаётся у элемента, браузер его выполняет, только при изменении самого элемента, в данном случае его координат

// Firefox блокирует вывод одинаковых сообщений!

function onElementRectChange(node, callback) {
  
  let lastRect = node.getBoundingClientRect(), newRect;
  
  // функция проверки которая будет выполняться при каждом вызове таймером
  (function run() {
  newRect = node.getBoundingClientRect();
  
  if (newRect.left !== lastRect.left ||
    newRect.top !== lastRect.top ||
    newRect.right !== lastRect.right ||
    newRect.bottom !== lastRect.bottom) {
    callback(newRect);
  }
  lastRect = newRect;
  
  // создаём у элемента таймер и указываем функцию и временем в мс
  node.onElementRectChangeTimer =  setInterval(run, 250);
  })();
}

function callback(rect) {
  // тут бызов наших функций
  //console.log('Координаты элемента изменились! ' + rect.left + ' ' + rect.top)
}

onElementRectChange(node, callback);
// для проверки достаточно прокрутить страницу