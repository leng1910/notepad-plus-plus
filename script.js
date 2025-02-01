function askHowMuch(lovesMe) {
    const contentDiv = document.getElementById('content');
    if (lovesMe) {
        contentDiv.innerHTML = `
            <h1>How much?</h1>
            <button onclick="askValentine('so much')">So much</button>
            <button onclick="askValentine('little')">Little</button>
        `;
    } else {
        showResult(false);
    }
}

function askValentine(howMuch) {
    const contentDiv = document.getElementById('content');
    if (howMuch === 'so much') {
        contentDiv.innerHTML = `
            <h1>Do you want to be my Valentine?</h1>
            <button onclick="showResult(true)">Yes</button>
            <button onclick="showResult(false)">No</button>
        `;
    } else {
        showResult(false);
    }
}

function showResult(valentine) {
    const contentDiv = document.getElementById('content');
    if (valentine) {
        contentDiv.innerHTML = '<h1>HOORAY I LOVE YOU! ❤️</h1>';
        addFloatingElements('flower', 40);
    } else {
        contentDiv.innerHTML = '<h1>Aww :(</h1>';
    }
    addFloatingElements('heart', 20);
}

// Function to add floating elements
function addFloatingElements(type, count) {
    for (let i = 0; i < count; i++) {
        let element = document.createElement('div');
        element.className = type;
        document.body.appendChild(element);
    }
}

// Floating hearts effect
document.addEventListener('DOMContentLoaded', function() {
    addFloatingElements('heart', 20);
});
