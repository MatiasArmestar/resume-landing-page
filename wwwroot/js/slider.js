window.slider = {

    init: (element, dotNetRef) => {

        element.addEventListener("scroll", () => {
            const page = Math.round(element.scrollLeft / element.clientWidth);
            dotNetRef.invokeMethodAsync("SetPage", page);
        });

    }

};