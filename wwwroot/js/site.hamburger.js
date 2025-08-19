// Drawer toggle logic
(function(){
  const drawer = document.getElementById('mobileDrawer');
  const burger = document.getElementById('hamburger');
  const closeBtn = document.getElementById('drawerClose');
  const backdrop = document.getElementById('backdrop');

  if(!drawer || !burger || !backdrop) return;

  const openDrawer = () => {
    drawer.classList.add('open');
    drawer.setAttribute('aria-hidden','false');
    burger.setAttribute('aria-expanded','true');
    backdrop.hidden = false;
    // focus first link
    const firstLink = drawer.querySelector('a');
    if(firstLink) firstLink.focus();
  };
  const closeDrawer = () => {
    drawer.classList.remove('open');
    drawer.setAttribute('aria-hidden','true');
    burger.setAttribute('aria-expanded','false');
    backdrop.hidden = true;
    burger.focus();
  };

  burger.addEventListener('click', (e)=>{
    const isOpen = drawer.classList.contains('open');
    isOpen ? closeDrawer() : openDrawer();
  });
  closeBtn && closeBtn.addEventListener('click', closeDrawer);
  backdrop.addEventListener('click', closeDrawer);
  document.addEventListener('keydown', (e)=>{
    if(e.key === 'Escape') closeDrawer();
  });
})();