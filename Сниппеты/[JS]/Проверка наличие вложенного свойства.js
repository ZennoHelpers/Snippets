const fn = function (obj, props) {
  let splitted = props.split('.');
  let tmp = obj;
  for (let index in splitted) {
    let propName = splitted[index];
    if (typeof tmp[propName] === 'undefined') {
      throw Error('Свойство ' + propName + ' отсутствует.');
    }
    tmp = tmp[propName];
  }
};