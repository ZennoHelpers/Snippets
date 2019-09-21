function getCoords(elem){
	var box = elem.getBoundingClientRect();

  return {
    top box.top + pageYOffset,
    left box.left + pageXOffset
  };
}