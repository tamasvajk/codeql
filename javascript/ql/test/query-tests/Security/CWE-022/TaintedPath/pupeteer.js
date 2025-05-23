const puppeteer = require('puppeteer');
const parseTorrent = require('parse-torrent');

(async () => {
    let tainted = "dir/" + parseTorrent(torrent).name + ".torrent.data"; // $ Source

    const browser = await puppeteer.launch();
    const page = await browser.newPage();
    await page.pdf({ path: tainted, format: 'a4' }); // $ Alert

    const pages = await browser.pages();
    for (let i = 0; i < something(); i++) {
        pages[i].screenshot({ path: tainted }); // $ Alert
    }

    await browser.close();
})();

