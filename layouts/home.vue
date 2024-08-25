<template>
  <div class="homeLayoutWrapper">
    <div class="navTop">
      <img id="iconSun" src="../public/SUN.png" />
      <img id="iconAnd" src="../public/&.png" />
      <div id="layerForSwitcher">
        <button id="sunAndMoonSwitcher"><img src="../public/sunPicture.png" /></button>
      </div>
      <img id="iconMoon" src="../public/MOON.png" />
    </div>
    <slot>
    </slot>
    <div class="navBottom">
      home layout ~ Home page bottom
    </div>
  </div>
</template>

<script lang="ts" setup>


</script>

<style lang="postcss" scoped>
.navTop,
.navBottom {
  @apply flex justify-center w-full h-20 items-center;
}

.homeLayoutWrapper {
  @apply w-full bg-[#FFE7B8];
}

#iconAnd,
#iconSun,
#iconMoon {
  @apply relative;
}

#iconAnd {
  @apply left-[3.2rem] top-[4rem] z-10;
}

#iconSun {
  @apply left-[4.2rem] top-[6.4rem];
}

#iconMoon {
  @apply top-[5.2rem] right-[2.4rem];
}

#layerForSwitcher {
  @apply relative right-[4.4rem] w-[3.9rem] top-[6.4rem] bg-[gray] h-[4rem] z-0
}

#sunAndMoonSwitcher {
  @apply relative left-[0.5rem] w-[3.7rem] h-[4rem] z-20;
}
</style>