<template>
  <div class="homeLayoutWrapper">
    <div class="navTop">
      <img id="iconSun" src="../public/SUN.png" />
      <img id="iconAnd" src="../public/&.png" />
      <img id="iconMoon" src="../public/MOON.png" />
    </div>
    <button id="sunAndMoonSwitcher"><img src="../public/sunPicture.png" /></button>
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
  @apply left-[3.2rem] top-[4rem] ;
}

#iconSun {
  @apply left-[4.2rem] top-[6.4rem];
}

#iconMoon {
  @apply top-[5.2rem] left-[1.5rem];
}

#sunAndMoonSwitcher {
  @apply absolute left-[37.7rem] w-[3.7rem] top-[6.8rem] h-[4rem];
}
</style>