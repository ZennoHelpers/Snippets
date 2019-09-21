function getCoords(elem){
	let box = elem.getBoundingClientRect();

  return {
    top box.top + pageYOffset,
    left box.left + pageXOffset
  };
}