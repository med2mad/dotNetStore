// Fonction pour détecter si l'appareil est mobile
function isMobileDevice() {
    return window.innerWidth <= 992;
}

// Fonction pour enregistrer le listener de redimensionnement
function registerResizeListener(dotNetHelper) {
    window.addEventListener('resize', () => {
        dotNetHelper.invokeMethodAsync('HandleResize');
    });
}

// Exportez les fonctions pour qu'elles soient accessibles depuis Blazor
window.adminLayout = {
    isMobileDevice,
    registerResizeListener
};



// Vérifie si l'écran est en mode mobile
window.ToggleSidebar = function () {
    console.log("JS ToggleSidebar called by C#");
    dotNetAdminHelper.invokeMethodAsync('ToggleSidebar');


};

window.initializeAdminInterop = (dotNetHelper) => {
    window.dotNetAdminHelper = dotNetHelper;
    return "444";
};

function isMobile() {
    return true;
}


window.initAdminLayout = function (dotnetRef) {
    // You can call this from C#:
    window.ToggleSidebar = function () {
        console.log("JS ToggleSidebar called by C#");
        window.dotNetAdminHelper.invokeMethodAsync('ToggleSidebar');
    };
};
// Attach native JS click handler
const btn = document.getElementById("toggleSidebarBtn");
if (btn) {
    btn.addEventListener("click", () => {
        window.ToggleSidebar();
    });
}

// Enregistre le listener de redimensionnement
function registerAdminLayout(dotNetHelper) {
    function handleResize() {
        dotNetHelper.invokeMethodAsync('HandleWindowResize');
    }

    window.addEventListener('resize', handleResize);

    window.ToggleSidebar = () => {
        console.log("222");
        window.dotNetAdminHelper.invokeMethodAsync('ToggleSidebar');
    }

    // Cleanup function
    return {
        dispose: () => {
            window.removeEventListener('resize', handleResize);
        }
    };
}

// Exporte les fonctions
window.adminLayout = {
    isMobile,
    registerAdminLayout
};

window.setupDropdownClose = (dotNetObjRef, dropdownId) => {
    document.addEventListener('click', function (event) {
        if (!event.target.closest('.dropdown')) {
            dotNetObjRef.invokeMethodAsync('CloseDropdown');
        }
    });
}

