<template>
  <div class="flex h-screen w-screen">
    <!-- Sidebar -->
    <div :class="sidebarOpen ? 'w-64' : 'w-16'" class="bg-gray-800 text-white">
      <!-- Sidebar content -->
      <div class="p-5">
        <!-- Sidebar logo or title -->
        <h1 class="text-lg font-semibold">Sidebar</h1>

        <!-- Sidebar links -->
        <ul class="mt-5">
          <li v-for="item in menuItems" :key="item.id">
            <a
              href="#"
              class="flex items-center px-3 py-2 rounded-md"
              :class="{
                'text-gray-300': !item.active,
                'text-white': item.active,
                'bg-slate-600': item.active
              }"
              @mouseover="hoverItem(item.id)"
              @mouseleave="leaveItem(item.id)"
            >
              <svg
                v-if="item.active"
                xmlns="http://www.w3.org/2000/svg"
                class="h-5 w-5 mr-2"
                viewBox="0 0 20 20"
                fill="currentColor"
              >
                <path fill-rule="evenodd" d="M10 12a2 2 0 100-4 2 2 0 000 4z" />
                <path
                  fill-rule="evenodd"
                  d="M3 10a7 7 0 1114 0 7 7 0 01-14 0zm7-6a1 1 0 00-1 1v5a1 1 0 002 0V5a1 1 0 00-1-1z"
                  clip-rule="evenodd"
                />
              </svg>
              {{ item.text }}
            </a>
          </li>
        </ul>
      </div>
    </div>

    <!-- Main content -->
    <div class="w-full h-full">
      <div class="bg-slate-500 py-4 px-6">header</div>
      <RouterView class="flex-1 p-10" />
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      sidebarOpen: true,
      menuItems: [
        { id: 1, text: 'Dashboard', active: false },
        { id: 2, text: 'Posts', active: false }
        // Add more menu items as needed
      ]
    }
  },
  methods: {
    toggleSidebar() {
      this.sidebarOpen = !this.sidebarOpen
    },
    hoverItem(id) {
      this.menuItems.forEach((item) => {
        if (item.id === id) {
          item.active = true
        }
      })
    },
    leaveItem(id) {
      this.menuItems.forEach((item) => {
        if (item.id === id) {
          item.active = false
        }
      })
    }
  }
}
</script>
