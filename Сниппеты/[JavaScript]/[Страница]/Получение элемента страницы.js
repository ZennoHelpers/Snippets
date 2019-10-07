let xPathTarget = document.evaluate(`id('content')`, document.documentElement, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null);
let node = xPathTarget.singleNodeValue;

return node.innerHTML;