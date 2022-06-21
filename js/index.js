'use strict';

document.getElementById('openButton').addEventListener('click', open);
document.getElementById('hideButton').addEventListener('click', hide);
document.getElementById('reset').addEventListener('click', reset);
document.getElementById('filterButton').addEventListener('click', filter);
document.getElementById('hideFilter').addEventListener('click', filter);
let hideFilterButton = document.getElementsByClassName('hide');
for (let elem of hideFilterButton){
    elem.addEventListener('click', hideFilter);
}
function filter(event){
    document.getElementById('filter').classList.toggle('filterClose');
    document.getElementById('cards').classList.toggle('cardsClose');
}
function chooseSize(event){
    let size = document.getElementsByClassName('size');
    for (let i = 0; i < size.length; i++){
        if(event.target.classList.contains('add')){
            if(i  === +event.target.dataset.card){
                size[i].classList.remove('hideSize');
            }
        }
        if(event.target.classList.contains('close')){
            if(i  === +event.target.dataset.close){
                size[i].classList.add('hideSize');
            }
        }
    }
}

function plusMinus(event){
    for (let i = 0; i < inputs.length; i++){
        if(i === +event.target.dataset.inputs){
            if(event.target.classList.contains('plus')){
                inputs[i].value = +inputs[i].value + 1;
            }
            if(event.target.classList.contains('minus')){
                if(inputs[i].value > 0)
                inputs[i].value = +inputs[i].value - 1;
            }
        }
    }
}


function hideFilter(event){
    let hideParts = document.getElementsByClassName('hidePart');
    let hrs = document.getElementsByClassName('line');
    for (let i = 0; i < hideParts.length; i++){
        if(i+1  === +event.target.dataset.hide){
            if (hideParts[i].classList.contains('hideFilter')){
                hideParts[i].classList.remove('hideFilter');
                hideFilterButton[i].style.transform = "none";
                hrs[i].style.marginTop = "20px";
            } else{
                hideParts[i].classList.add('hideFilter');
                hideFilterButton[i].style.transform = "rotate(180deg)";
                hrs[i].style.marginTop = "0";
            }
        }
    }
}

function open(event){
    document.getElementById('hiddenCategories').classList.remove("hidden");
    document.getElementById('openButton').classList.add("hidden");
}
function hide(event){
    document.getElementById('hiddenCategories').classList.add("hidden");
    document.getElementById('openButton').classList.remove("hidden");
}

function reset(event){
    let inputArr = document.querySelectorAll("input[type=checkbox]");
    inputArr.forEach(function(el) {
        el.checked = false;
    })
    let inputMin = document.getElementById('from'); // Ищем input с меньшим значнием
    let inputMax = document.getElementById('to'); // Ищем input с большим значнием
    inputMin.value = 15000;
    inputMax.value = 80000;
}
let cards = document.getElementById('cards');
for( let i = 0; i<20; i++){
    let card = document.createElement('div');
    card.innerHTML = ` 
                 <div class="image">
                  <img src="img/example.jpg" alt="example">
                </div>
                <p>Арт 1232425</p>
                <span class="description">Костюм "СИРИУС-Горка" куртка, брюки (гражданские размеры) КМФ Мультикам</span>
                <span class="optPrice">Опт 3144 ₽</span>
                <span class="roznPrice">Розница 4235 ₽</span>    
                <div class="action">
                    <div class="add" data-card="`+i+`">
                        <span>В корзину</span>
                    </div>
                    <div class="like">
                    </div>
                </div>
                <div class="size hideSize">
                    <div class="firstLineOfSize">
                        <span class="chooseOption">Выбор опций</span>
                        <img src="img/close.png" data-close="`+i+`" class="close" alt="close">
                    </div>
                    <div class="secondLineSize">
                        <span class="titleSize">Размерный ряд</span>
                        <span class="titleSize">Количество</span>
                    </div>
                    <div class="listOfSizes">
                        <div class="sizeType">
                            <span>Размер 104-108, Рост 170-176 (Арт. 43585)</span>
                            <input type="number" class="count"  placeholder="0" min="0">
                            <div class="btns">
                                <div class="plus">+</div>
                                <div class="minus">-</div>
                            </div> 
                        </div>
                        <hr class="line" noshade width="100%">
                        <div class="sizeType">
                            <span>Размер 104-108, Рост 170-176 (Арт. 43585)</span>
                            <input type="number" class="count" placeholder="0" min="0">
                            <div class="btns">
                                <div class="plus">+</div>
                                <div class="minus">-</div>
                            </div> 
                        </div>
                        <hr class="line" noshade width="100%">
                        <div class="sizeType">
                            <span>Размер 104-108, Рост 170-176 (Арт. 43585)</span>
                            <input type="number" class="count" placeholder="0" min="0">
                           <div class="btns">
                                <div class="plus">+</div>
                                <div class="minus">-</div>
                            </div> 
                        </div>
                        <hr class="line" noshade width="100%">
                        <div class="sizeType">
                            <span>Размер 104-108, Рост 170-176 (Арт. 43585)</span>
                            <input type="number" class="count"  placeholder="0" min="0">
                            <div class="btns">
                                <div class="plus">+</div>
                                <div class="minus">-</div>
                            </div>  
                        </div>
                        <hr class="line" noshade width="100%">
                        <div class="sizeType">
                            <span>Размер 104-108, Рост 170-176 (Арт. 43585)</span>
                            <input type="number" class="count" placeholder="0" min="0">
                            <div class="btns">
                                <div class="plus">+</div>
                                <div class="minus">-</div>
                            </div> 
                        </div>
                        <hr class="line" noshade width="100%">
                        <div class="sizeType">
                            <span>Размер 104-108, Рост 170-176 (Арт. 43585)</span>
                            <input type="number" class="count" placeholder="0" min="0">
                            <div class="btns">
                                <div class="plus">+</div>
                                <div class="minus">-</div>
                            </div> 
                        </div>
                        <hr class="line" noshade width="100%">
                        <div class="sizeType">
                            <span>Размер 104-108, Рост 170-176 (Арт. 43585)</span>
                            <input type="number" class="count" placeholder="0" min="0">
                            <div class="btns">
                                <div class="plus">+</div>
                                <div class="minus">-</div>
                            </div> 
                        </div>
                        <hr class="line" noshade width="100%">
                    </div>   
                </div>`;
    card.classList.add('card');
    var inputs = document.getElementsByClassName('count');
    let plus = document.getElementsByClassName('plus');
    let minus = document.getElementsByClassName('minus');
    for (let i = 0; i < inputs.length; i++){
       minus[i].setAttribute('data-inputs', i);
       plus[i].setAttribute('data-inputs', i);
    }
    cards.appendChild(card);
}

cards.addEventListener('click', chooseSize);
cards.addEventListener('click', plusMinus);


