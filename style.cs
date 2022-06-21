@charset "UTF-8";
@import url("https://fonts.googleapis.com/css2?family=Roboto&display=swap");
#page {
  margin: 0;
  font-family: "Roboto", sans-serif;
  font-size: 12px;
  color: #828282;
  display: grid;
  grid-template-columns: 10% 80% 10%;
}

header {
  display: flex;
  justify-content: space-evenly;
  grid-column: 2/3;
  height: 80px;
  align-items: center;
}
header .location, header .time, header .contacts {
  display: flex;
  flex-direction: column;
}
header img {
  height: 80px;
  width: 95px;
}
header .location .city {
  color: #E93C3C;
  font-size: 14px;
}
header .location .city img {
  height: 14.67px;
  width: 12px;
}
header .search {
  display: inline-flex;
  flex-direction: row-reverse;
  width: 372px;
  border: 1px solid #828282;
}
header .search img {
  margin-top: 10px;
  padding-right: 15px;
  width: 14px;
  height: 14px;
  position: absolute;
}
header .search input {
  height: 34px;
  width: 100%;
  outline: none;
  border: none;
}
header .icons {
  display: flex;
  justify-content: center;
}
header .icons img {
  width: 24px;
  height: 24px;
  margin-right: 10px;
}
header .contacts .contacts-number {
  font-weight: bold;
}
header .contacts .feedback {
  text-decoration: none;
  color: #EB4747;
}

nav {
  display: grid;
  grid-template-columns: 10% 80% 10%;
  grid-column: 1/4;
  background-color: #F2F2F2;
}
nav .navbar {
  font-size: 14px;
  display: flex;
  grid-column: 2/3;
  align-items: center;
}
nav .navbar .catalog {
  display: flex;
  flex-direction: row;
  align-items: center;
  background-color: #EB4747;
  color: white;
  height: 100%;
}
nav .navbar .catalog a {
  color: white;
}
nav .navbar .catalog img {
  margin-left: 12px;
  margin-top: 5px;
  width: 18px;
  height: 18px;
}
nav .navbar a {
  color: #828282;
  text-decoration: none;
  padding: 15px 12px;
}
nav .navbar a:hover,
nav .navbar a:active {
  border-bottom: 2px solid #E93C3C;
}
nav .navbar .trueSign {
  color: #EB4747;
  text-transform: uppercase;
  font-weight: bold;
}

.route {
  margin-top: 40px;
  grid-column: 2/3;
  color: #828282;
}
.route h1 {
  color: #25282B;
  text-transform: uppercase;
}

.categories {
  grid-column: 2/3;
  display: flex;
  flex-wrap: wrap;
}
.categories a {
  text-decoration: none;
  color: #52575C;
  padding: 8.5px 8px;
  border: 1px solid #CACCCF;
  margin-right: 8px;
  margin-bottom: 8px;
}
.categories a:hover {
  background-color: #E93C3C;
  color: white;
}
.categories .hidden {
  display: none !important;
}
.categories #hiddenCategories {
  display: flex;
  flex-wrap: wrap;
}
.categories #hideButton, .categories #openButton {
  border: 1px solid #E93C3C;
}
.categories #hideButton:hover, .categories #openButton:hover {
  color: #E93C3C;
}

.sort {
  grid-column: 2/3;
  display: flex;
  flex-direction: row-reverse;
}
.sort select {
  outline: none;
  border: none;
  height: 28px;
  width: 187px;
  font-size: 14px;
}
.sort select option {
  outline: none;
  border: none;
}

.main {
  grid-column: 2/3;
  display: grid;
  grid-template-columns: repeat(5, 1fr);
}
.main .filter {
  background: #F9F9FA;
  padding: 20px;
}
.main .filter hr {
  width: 100%;
  border-style: solid;
  border-width: 0.5px;
  border-color: #E8E8E8;
  margin-top: 15px;
}
.main .filter .hideFilter {
  display: none !important;
}
.main .filter .price .title, .main .filter .type .title, .main .filter .season .title, .main .filter .Brend .title, .main .filter .sex .title,
.main .filter .structure .title, .main .filter .material .title, .main .filter .warm .title, .main .filter .purpose .title,
.main .filter .colors .title {
  margin-top: 13px;
  display: flex;
  justify-content: space-between;
}
.main .filter .price .title img, .main .filter .type .title img, .main .filter .season .title img, .main .filter .Brend .title img, .main .filter .sex .title img,
.main .filter .structure .title img, .main .filter .material .title img, .main .filter .warm .title img, .main .filter .purpose .title img,
.main .filter .colors .title img {
  width: 12px;
  height: 6px;
}
.main .filter .price span, .main .filter .type span, .main .filter .season span, .main .filter .Brend span, .main .filter .sex span,
.main .filter .structure span, .main .filter .material span, .main .filter .warm span, .main .filter .purpose span,
.main .filter .colors span {
  font-size: 16px;
  color: #25282B;
  font-weight: 500;
  margin-bottom: 14px;
}
.main .filter .price {
  display: flex;
  flex-direction: column;
}
.main .filter .price input {
  box-sizing: border-box;
  width: 92px;
  text-align: right;
}
.main .filter .price input::-webkit-outer-spin-button,
.main .filter .price input::-webkit-inner-spin-button {
  -webkit-appearance: none;
  margin: 0;
}
.main .filter .price p {
  position: absolute;
  color: black;
  margin-top: 4px;
  margin-left: 5px;
}
.main .filter .price .inputPrice {
  display: flex;
  justify-content: space-between;
}
.main .filter .price .range {
  margin-bottom: 15px;
}
.main .filter .price .range .noUi-target {
  background: #CACCCF;
  height: 4px;
  margin-top: 33px;
}
.main .filter .price .range .noUi-connect {
  background: #FF6262;
  height: 4px;
}
.main .filter .price .range .noUi-handle {
  width: 20px;
  height: 20px;
  border: none;
  border-radius: 50%;
  background: #FF6262;
}
.main .filter .price .range .noUi-horizontal .noUi-handle {
  top: -9px;
}
.main .filter .price .range .noUi-handle:before,
.main .filter .price .range .noUi-handle:after {
  background: none;
  content: "•";
  font-size: 43px;
  font-weight: 700;
  left: 3px;
  color: white;
  line-height: 12px;
  position: absolute;
}
.main .filter .type .hidePart .listOfTypes, .main .filter .type .hidePart .list, .main .filter .season .hidePart .listOfTypes, .main .filter .season .hidePart .list, .main .filter .Brend .hidePart .listOfTypes, .main .filter .Brend .hidePart .list, .main .filter .sex .hidePart .listOfTypes, .main .filter .sex .hidePart .list, .main .filter .structure .hidePart .listOfTypes, .main .filter .structure .hidePart .list,
.main .filter .material .hidePart .listOfTypes,
.main .filter .material .hidePart .list, .main .filter .warm .hidePart .listOfTypes, .main .filter .warm .hidePart .list, .main .filter .purpose .hidePart .listOfTypes, .main .filter .purpose .hidePart .list, .main .filter .colors .hidePart .listOfTypes, .main .filter .colors .hidePart .list {
  display: flex;
  flex-direction: column;
}
.main .filter .type .hidePart .listOfTypes label, .main .filter .type .hidePart .list label, .main .filter .season .hidePart .listOfTypes label, .main .filter .season .hidePart .list label, .main .filter .Brend .hidePart .listOfTypes label, .main .filter .Brend .hidePart .list label, .main .filter .sex .hidePart .listOfTypes label, .main .filter .sex .hidePart .list label, .main .filter .structure .hidePart .listOfTypes label, .main .filter .structure .hidePart .list label,
.main .filter .material .hidePart .listOfTypes label,
.main .filter .material .hidePart .list label, .main .filter .warm .hidePart .listOfTypes label, .main .filter .warm .hidePart .list label, .main .filter .purpose .hidePart .listOfTypes label, .main .filter .purpose .hidePart .list label, .main .filter .colors .hidePart .listOfTypes label, .main .filter .colors .hidePart .list label {
  font-size: 16px;
  color: #52575C;
  margin-bottom: 15px;
}
.main .filter .type .hidePart .listOfTypes .custom-checkbox, .main .filter .type .hidePart .list .custom-checkbox, .main .filter .season .hidePart .listOfTypes .custom-checkbox, .main .filter .season .hidePart .list .custom-checkbox, .main .filter .Brend .hidePart .listOfTypes .custom-checkbox, .main .filter .Brend .hidePart .list .custom-checkbox, .main .filter .sex .hidePart .listOfTypes .custom-checkbox, .main .filter .sex .hidePart .list .custom-checkbox, .main .filter .structure .hidePart .listOfTypes .custom-checkbox, .main .filter .structure .hidePart .list .custom-checkbox,
.main .filter .material .hidePart .listOfTypes .custom-checkbox,
.main .filter .material .hidePart .list .custom-checkbox, .main .filter .warm .hidePart .listOfTypes .custom-checkbox, .main .filter .warm .hidePart .list .custom-checkbox, .main .filter .purpose .hidePart .listOfTypes .custom-checkbox, .main .filter .purpose .hidePart .list .custom-checkbox, .main .filter .colors .hidePart .listOfTypes .custom-checkbox, .main .filter .colors .hidePart .list .custom-checkbox {
  position: absolute;
  z-index: -1;
  opacity: 0;
}
.main .filter .type .hidePart .listOfTypes .custom-checkbox + label, .main .filter .type .hidePart .list .custom-checkbox + label, .main .filter .season .hidePart .listOfTypes .custom-checkbox + label, .main .filter .season .hidePart .list .custom-checkbox + label, .main .filter .Brend .hidePart .listOfTypes .custom-checkbox + label, .main .filter .Brend .hidePart .list .custom-checkbox + label, .main .filter .sex .hidePart .listOfTypes .custom-checkbox + label, .main .filter .sex .hidePart .list .custom-checkbox + label, .main .filter .structure .hidePart .listOfTypes .custom-checkbox + label, .main .filter .structure .hidePart .list .custom-checkbox + label,
.main .filter .material .hidePart .listOfTypes .custom-checkbox + label,
.main .filter .material .hidePart .list .custom-checkbox + label, .main .filter .warm .hidePart .listOfTypes .custom-checkbox + label, .main .filter .warm .hidePart .list .custom-checkbox + label, .main .filter .purpose .hidePart .listOfTypes .custom-checkbox + label, .main .filter .purpose .hidePart .list .custom-checkbox + label, .main .filter .colors .hidePart .listOfTypes .custom-checkbox + label, .main .filter .colors .hidePart .list .custom-checkbox + label {
  display: inline-flex;
  align-items: center;
  user-select: none;
}
.main .filter .type .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .type .hidePart .list .custom-checkbox + label::before, .main .filter .season .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .season .hidePart .list .custom-checkbox + label::before, .main .filter .Brend .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .Brend .hidePart .list .custom-checkbox + label::before, .main .filter .sex .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .sex .hidePart .list .custom-checkbox + label::before, .main .filter .structure .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .structure .hidePart .list .custom-checkbox + label::before,
.main .filter .material .hidePart .listOfTypes .custom-checkbox + label::before,
.main .filter .material .hidePart .list .custom-checkbox + label::before, .main .filter .warm .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .warm .hidePart .list .custom-checkbox + label::before, .main .filter .purpose .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .purpose .hidePart .list .custom-checkbox + label::before, .main .filter .colors .hidePart .listOfTypes .custom-checkbox + label::before, .main .filter .colors .hidePart .list .custom-checkbox + label::before {
  content: "";
  display: inline-block;
  width: 1em;
  height: 1em;
  flex-shrink: 0;
  flex-grow: 0;
  border: 1px solid #CACCCF;
  border-radius: 0.25em;
  margin-right: 0.5em;
  background-repeat: no-repeat;
  background-position: center center;
  background-size: 50% 50%;
}
.main .filter .type .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .type .hidePart .list .custom-checkbox:checked + label::before, .main .filter .season .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .season .hidePart .list .custom-checkbox:checked + label::before, .main .filter .Brend .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .Brend .hidePart .list .custom-checkbox:checked + label::before, .main .filter .sex .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .sex .hidePart .list .custom-checkbox:checked + label::before, .main .filter .structure .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .structure .hidePart .list .custom-checkbox:checked + label::before,
.main .filter .material .hidePart .listOfTypes .custom-checkbox:checked + label::before,
.main .filter .material .hidePart .list .custom-checkbox:checked + label::before, .main .filter .warm .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .warm .hidePart .list .custom-checkbox:checked + label::before, .main .filter .purpose .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .purpose .hidePart .list .custom-checkbox:checked + label::before, .main .filter .colors .hidePart .listOfTypes .custom-checkbox:checked + label::before, .main .filter .colors .hidePart .list .custom-checkbox:checked + label::before {
  border-color: #CACCCF;
  background-color: #E93C3C;
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 8 8'%3e%3cpath fill='%23fff' d='M6.564.75l-3.59 3.612-1.538-1.55L0 4.26 2.974 7.25 8 2.193z'/%3e%3c/svg%3e");
}
.main .filter .type .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .type .hidePart .list .custom-checkbox:disabled + label, .main .filter .season .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .season .hidePart .list .custom-checkbox:disabled + label, .main .filter .Brend .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .Brend .hidePart .list .custom-checkbox:disabled + label, .main .filter .sex .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .sex .hidePart .list .custom-checkbox:disabled + label, .main .filter .structure .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .structure .hidePart .list .custom-checkbox:disabled + label,
.main .filter .material .hidePart .listOfTypes .custom-checkbox:disabled + label,
.main .filter .material .hidePart .list .custom-checkbox:disabled + label, .main .filter .warm .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .warm .hidePart .list .custom-checkbox:disabled + label, .main .filter .purpose .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .purpose .hidePart .list .custom-checkbox:disabled + label, .main .filter .colors .hidePart .listOfTypes .custom-checkbox:disabled + label, .main .filter .colors .hidePart .list .custom-checkbox:disabled + label {
  color: #A0A4A8 !important;
  border-color: #E8E8E8;
}
.main .show {
  border: 1px solid #E93C3C;
  background-color: #F9F9FA;
  height: 48px;
  text-align: center;
}
.main .show span {
  font-size: 16px;
  color: #E93C3C;
  font-weight: 500;
  text-align: center;
}

/*# sourceMappingURL=style.cs.map */
