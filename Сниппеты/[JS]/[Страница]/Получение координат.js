let xPathTarget = document.evaluate(`id('content')`, document.documentElement, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null);
let node = xPathTarget.singleNodeValue;

function getCoords(node){
  let value = node.getBoundingClientRect();

  // Будет возвращён JSON с данными
  return JSON.stringify({bottom: value.bottom, height: value.height, left: value.left, right: value.right, top: value.top, width: value.width, pageY: value.top + pageYOffset, pageX: value.left + pageXOffset}, ['bottom', 'height', 'left', 'right', 'top', 'width', 'pageX', 'pageY']);
}

return getCoords(node);