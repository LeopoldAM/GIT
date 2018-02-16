function showImg() {
    var container = document.getElementById("itachi");

    var imgToAdd = document.createElement("img");
    imgToAdd.src = 'Pictures/Itachi_Mangekyô_Sharingan.png';
    imgToAdd.id = 'ImgGenerated';
    imgToAdd.click = changeImg;

    container.appendChild(imgToAdd);
    container.style.display = "block";
}

function changeImg() {
    count = 0;
    var imgToChange = document.getElementById("ImgGenerated");
    one = (count % 2 == 0) ? imgToChange.src = 'Pictures/Itachi_Mangekyô_Sharingan.png' : imgToChange.src = 'Pictures/Itachi_Mangekyô_Sharingan2.png';
    count++;

}

function hiddenImg() {
    var container = document.getElementById("itachi");

    container.removeChild(document.getElementById("ImgGenerated"));

    container.style.display = "none";

}

