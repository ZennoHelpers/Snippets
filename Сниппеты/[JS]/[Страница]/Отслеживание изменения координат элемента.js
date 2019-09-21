function onElementRectChange(node, callback) {
  // vars init
  let lastRect = node.getBoundingClientRect(), newRect;
  
  (function run() {
    newRect = node.getBoundingClientRect();
    if (newRect.left !== lastRect.left ||
        newRect.top !== lastRect.top ||
        newRect.right !== lastRect.right ||
        newRect.bottom !== lastRect.bottom) {
      callback();
    }
    lastRect = newRect;
    
    if (node.onElementRectChangeTimer) {
      clearTimeout(node.onElementRectChangeTimer);
    }
    node.onElementRectChangeTimer = setTimeout(run, 250);
  })();
}