function myFunction(elementID) {
  var x = document.getElementById(elementID);
  console.log(x.style.display)
  if (x.style.display === "none") {
    x.style.display = "block";
  } else {
    x.style.display = "none";
  }
}
