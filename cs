body {
    font-family: Arial, sans-serif;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #ffcccb;
    margin: 0;
    overflow: hidden;
    position: relative;
}

#content {
    text-align: center;
    z-index: 2;
}

button {
    margin: 10px;
    padding: 10px 20px;
    font-size: 16px;
    cursor: pointer;
    border: none;
    border-radius: 5px;
    background-color: #ff69b4;
    color: white;
}

button:hover {
    background-color: #ff1493;
}

.heart {
    width: 20px;
    height: 20px;
    position: absolute;
    background-color: pink;
    transform: rotate(-45deg);
    animation: floatHeart 5s infinite ease-in-out;
}

.heart::before,
.heart::after {
    content: '';
    width: 20px;
    height: 20px;
    position: absolute;
    background-color: pink;
    border-radius: 50%;
}

.heart::before {
    top: -10px;
    left: 0;
}

.heart::after {
    top: 0;
    left: 10px;
}

@keyframes floatHeart {
    0% {
        opacity: 1;
        transform: translateY(0) rotate(-45deg);
    }
    50% {
        opacity: 0.7;
        transform: translateY(-100px) rotate(-45deg);
    }
    100% {
        opacity: 0;
        transform: translateY(-200px) rotate(-45deg);
    }
}

#images {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-top: 20px;
}

.flower, .meme {
    max-width: 100%;
    height: auto;
    margin: 10px;
}
