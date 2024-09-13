module.exports = {
    proxy: "http://localhost:5191",
    files: ["wwwroot/**/*.*", "Views/**/*.cshtml", "wwwroot/css/**/*.css"],
    port: 3000,
    reloadDelay: 500
};