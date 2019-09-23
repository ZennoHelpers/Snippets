let testObj = {prop1: {prop2: {prop3: "a"}}};

function checkPropExist (obj, props) {
  let splitted = props.split('.');
  let tmp = obj;
  for (let index in splitted) {
    let propName = splitted[index];
    if (typeof tmp[propName] === 'undefined') {
      return false;
    }
    tmp = tmp[propName];
  }
  return true;
};

return checkPropExist(testObj, 'prop1.prop2.prop3');