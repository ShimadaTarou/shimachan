* {
  box-sizing: border-box;
}

body {
  margin: 0;
  font-family: "Hiragino Kaku Gothic ProN", sans-serif;
}

a {
  text-decoration: none;
}

.clear {
  clear: left;
}

.container {
  max-width: 1170px;
  width: 100%;
  padding: 0 15px;
  margin: 0 auto;
}

.top-wrapper {
  padding: 180px 0 180px 0;
  background-image: url(https://github.com/ShimadaTarou/shimachan/blob/master/IMG_3148.JPG?raw=true);
  background-size: cover;
  color: limegreen;
  text-align: center;
}

.top-wrapper h1 {
  opacity: 0.7;
  font-size: 45px;
  letter-spacing: 5px;
}

.top-wrapper p {
  opacity: 0.7;
}

.btn-wrapper {
  text-align: center;
}

.btn-wrapper p {
  margin: 10px 0;
}

.signup {
  background-color: #239b76;
}

.facebook {
  background-color: #3b5998;
  margin-right: 10px;
}

.twitter {
  background-color: #55acee;
}

.btn {
  color: white;
  display: inline-block;
  opacity: 0.8;
  border-radius: 4px;
  text-align: center;
}

.btn:hover {
  opacity: 1;
}

.fa {
  margin-right: 5px;
}

header {
  height: 65px;
  width: 100%;
  background-color: rgba(255, 255, 0, 0.7);
  position :fixed;
  top: 0;
  z-index: 10;
}

.logo {
  width: 124px;
  margin-top: 20px;
}

.header-left {
  float: left;
}

.header-left a{
  line-height: 65px;
  padding: 0 25px;
  color: black;
}

.header-right {
  float: right;
  margin-right: -25px;
}

.header-right a {
  line-height: 65px;
  padding: 0 25px;
  color: black;
  display: block;
  float: left;
  transition: all 0.5s;
}

.header-right a:hover {
  background-color: rgba(255, 255, 255, 0.3);
}

/* menu-iconのCSSを貼り付けてください */
.menu-icon {
  color: white;
  float: right;
  font-size: 25px;
  padding: 21px 0;
  /* displayをnoneに指定してください */
  display:none;
}

.heading {
  padding-top: 80px;
  padding-bottom: 50px;
  color: #5f5d60;
}

.heading h2 {
  font-weight: normal;
}

.heading h3 {
  font-weight: normal;
}

footer img {
  width: 125px;
}

footer p {
  color: #b3aeb5;
  font-size: 12px;
}

footer {
  padding-top: 30px;
  padding-bottom: 20px;
}
